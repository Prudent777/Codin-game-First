﻿//------------------------------------------------------
// 
// Copyright - (c) - 2014 - Mille Boström 
//
// Youtube channel - http://www.speedcoding.net
//------------------------------------------------------

using System;

namespace LetsCreateNetworkGame.OpenGL.MyEventArgs
{
    public class NewInputEventArgs : EventArgs
    {
        public Input Input { get; set; }

        public NewInputEventArgs(Input input)
        {
            Input = input; 
        }
    }
}



