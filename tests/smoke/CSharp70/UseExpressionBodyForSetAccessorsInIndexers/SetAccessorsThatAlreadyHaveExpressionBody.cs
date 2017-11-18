﻿// ReSharper disable All

using System;

namespace CSharp70.UseExpressionBodyForSetAccessorsInIndexers
{
    public class SetAccessorsThatAlreadyHaveExpressionBody
    {
        public string S { get; set; }
        private int i;

        public int this[int index]
        {
            get => i;
            set => i = 0;
        }
        public string this[string index]
        {
            get => S ?? throw new ArgumentNullException(nameof(S));
            set => S = string.Empty ?? throw new ArgumentNullException(nameof(S));
        }
        public double this[double index]
        {
            get => Convert.ToDouble(S.ToUpper().ToLower());
            set => Convert.ToDouble(S.ToUpper().ToLower());
        }
    }

    public class SetAccessorsWithoutGettersThatAlreadyHaveExpressionBody
    {
        public string S { get; set; }
        private int i;

        public int this[int index]
        {
            set => i = 0;
        }
        public string this[string index]
        {
            set => S = string.Empty ?? throw new ArgumentNullException(nameof(S));
        }
        public double this[double index]
        {
            set => Convert.ToDouble(S.ToUpper().ToLower());
        }
    }

    public class SetAccessorsThatAlreadyHaveExpressionBodyWithComments
    {
        public string S { get; set; }
        private int i;

        public int this[int index]
        {
            get => i;
            set =>
                // This is some comment.
                i = 0;
        }
        public string this[string index]
        {
            get => S ?? throw new ArgumentNullException(nameof(S));
            set =>
                // This is some comment.
                S = string.Empty ?? throw new ArgumentNullException(nameof(S));
        }
        public double this[double index]
        {
            get => Convert.ToDouble(S.ToUpper().ToLower());
            set =>
                // This is some comment.
                Convert.ToDouble(S.ToUpper().ToLower());
        }
    }

    public class SetAccessorsWithoutGettersThatAlreadyHaveExpressionBodyWithComments
    {
        public string S { get; set; }
        private int i;

        public int this[int index]
        {
            set =>
                // This is some comment.
                i = 0;
        }
        public string this[string index]
        {
            set =>
                // This is some comment.
                S = string.Empty ?? throw new ArgumentNullException(nameof(S));
        }
        public double this[double index]
        {
            set =>
                // This is some comment.
                Convert.ToDouble(S.ToUpper().ToLower());
        }
    }
}