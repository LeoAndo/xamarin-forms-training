﻿using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace BindablePropertySample
{
    public class CountedLabel : Label
    {

        static readonly BindablePropertyKey WordCountKey =
           BindableProperty.CreateReadOnly("WordCount",            // propertyName
                                            typeof(int),            // returnType
                                            typeof(CountedLabel),   // declaringType
                                            0);                     // defaultValue

        public static readonly BindableProperty WordCountPropety =
            WordCountKey.BindableProperty;


        public CountedLabel()
        {
            PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
            {
                if (args.PropertyName == "Text")
                {
                    if (String.IsNullOrEmpty(Text))
                    {
                        WordCount = 0;
                    }
                    else
                    {
                        WordCount = Text.Split(' ', '-', '\u2014').Length;
                    }
                }
            };
        }

        public int WordCount
        {
            private set { SetValue(WordCountKey, value); }
            get { return (int)GetValue(WordCountPropety); }
        }
    }
}
