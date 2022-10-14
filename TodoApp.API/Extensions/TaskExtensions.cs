﻿using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TodoApp.API.Extensions
{
    public static class TaskExtensions
    {
        public static ConfiguredTaskAwaitable AnyContext(this Task task)
        {
            return task.ConfigureAwait(false);
        }

        public static ConfiguredTaskAwaitable<T> AnyContext<T>(this Task<T> task)
        {
            return task.ConfigureAwait(false);
        }
    }
}