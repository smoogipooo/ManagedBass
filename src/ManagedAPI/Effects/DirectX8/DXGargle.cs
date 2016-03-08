﻿using ManagedBass.Dynamics;
using System.Runtime.InteropServices;

namespace ManagedBass.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public class DXGargleParameters : IEffectParameter
    {
        public int dwRateHz; // Rate of modulation in hz
        public DXWaveform dwWaveShape;

        public EffectType FXType => EffectType.DXGargle;
    }

    public sealed class DXGargleEffect : Effect<DXGargleParameters>
    {
        public DXGargleEffect(int Handle) : base(Handle) { }

        public int Rate
        {
            get { return Parameters.dwRateHz; }
            set
            {
                Parameters.dwRateHz = value;

                OnPropertyChanged();
                Update();
            }
        }

        public DXWaveform WaveShape
        {
            get { return Parameters.dwWaveShape; }
            set
            {
                Parameters.dwWaveShape = value;

                OnPropertyChanged();
                Update();
            }
        }
    }
}