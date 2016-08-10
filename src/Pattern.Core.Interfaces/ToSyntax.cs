﻿namespace Pattern.Core.Interfaces
{
    public class ToSyntax<TFrom> : IToSyntax<TFrom>
    {
        private readonly IKernel kernel;

        public ToSyntax(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public void ToSelf()
        {
            this.kernel.Bind(typeof(TFrom), typeof(TFrom));
        }

        public void To<TTo>()
            where TTo:TFrom
        {
            this.kernel.Bind(typeof(TFrom), typeof(TTo));
        }
    }
}