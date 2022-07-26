﻿using System;
using Microsoft.Extensions.Logging;

namespace ProjectK.Extensions.Logging;

public static class LoggerExtensions
{
    /// <summary>
    /// Global Logger3AAA Extension
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="e"></param>
    public static void LogError(this ILogger logger, Exception e)
    {
        logger.Log(LogLevel.Error, e.Message);
        var stacks = e.StackTrace.Split("\r\n");
        foreach (var stack in stacks) logger.Log(LogLevel.Error, stack);
    }
}