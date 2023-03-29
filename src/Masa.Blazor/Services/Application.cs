﻿using System.ComponentModel;

namespace Masa.Blazor
{
    public class Application : INotifyPropertyChanged
    {
        private double _bar;
        private double _top;
        private double _left;
        private double _insetFooter;
        private double _right;
        private double _bottom;
        private double _footer;

        /// <summary>
        /// Determines if the value of <see cref="Left"/> or <see cref="Right"/> has been set.
        /// The value would be set when value was calculated from JS.
        /// </summary>
        public bool LeftRightCalculated { get; private set; }

        /// <summary>
        /// Determines if the value of <see cref="InsetFooter"/> or <see cref="Footer"/> has been set.
        /// The value would be set when value was calculated from JS.
        /// </summary>
        public bool FooterCalculated { get; private set; }

        public double Bar
        {
            get => _bar;
            internal set
            {
                if (_bar != value)
                {
                    _bar = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bar)));
                }
            }
        }

        public double Top
        {
            get => _top;
            internal set
            {
                if (_top != value)
                {
                    _top = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Top)));
                }
            }
        }

        public double Left
        {
            get => _left;
            internal set
            {
                if (_left != value)
                {
                    LeftRightCalculated = true;
                    _left = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Left)));
                }
            }
        }

        public double InsetFooter
        {
            get => _insetFooter;
            internal set
            {
                if (_insetFooter != value)
                {
                    FooterCalculated = true;
                    _insetFooter = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(InsetFooter)));
                }
            }
        }

        public double Right
        {
            get => _right;
            internal set
            {
                if (_right != value)
                {
                    LeftRightCalculated = true;
                    _right = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Right)));
                }
            }
        }

        public double Bottom
        {
            get => _bottom;
            internal set
            {
                if (_bottom != value)
                {
                    _bottom = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bottom)));
                }
            }
        }

        public double Footer
        {
            get => _footer;
            internal set
            {
                if (_footer != value)
                {
                    FooterCalculated = true;
                    _footer = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Footer)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
