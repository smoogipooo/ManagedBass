﻿using ManagedBass.Dynamics;
using System.Runtime.InteropServices;

namespace ManagedBass.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public class DXFlangerParameters : IEffectParameter
    {
        public float fWetDryMix;
        public float fDepth;
        public float fFeedback;
        public float fFrequency;
        public DXWaveform lWaveform;
        public float fDelay;
        public DXPhase lPhase;

        public EffectType FXType => EffectType.DXFlanger;
    }

    public sealed class DXFlangerEffect : Effect<DXFlangerParameters>
    {
        public DXFlangerEffect(int Handle) : base(Handle) { }

        public double WetDryMix
        {
            get { return Parameters.fWetDryMix; }
            set
            {
                Parameters.fWetDryMix = (float)value;

                OnPropertyChanged();
                Update();
            }
        }

        public double Depth
        {
            get { return Parameters.fDepth; }
            set
            {
                Parameters.fDepth = (float)value;

                OnPropertyChanged();
                Update();
            }
        }

        public double Feedback
        {
            get { return Parameters.fFeedback; }
            set
            {
                Parameters.fFeedback = (float)value;

                OnPropertyChanged();
                Update();
            }
        }

        public double Frequency
        {
            get { return Parameters.fFrequency; }
            set
            {
                Parameters.fFrequency = (float)value;

                OnPropertyChanged();
                Update();
            }
        }

        public DXWaveform Waveform
        {
            get { return Parameters.lWaveform; }
            set
            {
                Parameters.lWaveform = value;

                OnPropertyChanged();
                Update();
            }
        }

        public double Delay
        {
            get { return Parameters.fDelay; }
            set
            {
                Parameters.fDelay = (float)value;

                OnPropertyChanged();
                Update();
            }
        }

        public DXPhase Phase
        {
            get { return Parameters.lPhase; }
            set
            {
                Parameters.lPhase = value;

                OnPropertyChanged();
                Update();
            }
        }
    }
}