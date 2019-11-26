﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TongFang
{
    public enum Effect : byte
    {
        Static = 1,
        Breathing = 2,
        Wave = 3,
        Reactive = 4,
        Rainbow = 5,
        Ripple = 6,
        Nomo = 8,
        Marquee = 9,
        Raindrop = 10,
        Stack = 12,
        Impact = 13,
        Aurora = 14,
        Neon = 15,
        Spark = 17,
        Flash = 18,
        Mix = 19,
        Music = 34,
        UserMode = 51,
        Unknown = 255
    }

    public enum EffecType : byte
    {
        FW = 0,
        ROW = 1,
        PICTURE = 2,
        MUSIC = 3,
        AP = 4
    }

    public enum Control : byte
    {
        Off = 1,
        Default = 2,
        Welcome = 3
    }

    public enum Key : byte
    {
        ESCAPE,

        F1,

        F2,

        F3,

        F4,

        F5,

        F6,

        F7,

        F8,

        F9,

        F10,

        F11,

        F12,

        INSERT,

        DELETE,

        HOME,

        END,

        PAGE_UP,

        PAGE_DOWN,

        TILDE,

        ONE,

        TWO,

        THREE,

        FOUR,

        FIVE,

        SIX,

        SEVEN,

        EIGHT,

        NINE,

        ZERO,

        MINUS,

        EQUALS,

        BACKSPACE,

        NUMLOCK,

        NUMPAD_DIVIDE,

        NUMPAD_MULTIPLY,

        NUMPAD_MINUS,

        TAB,

        Q,

        W,

        E,

        R,

        T,

        Y,

        U,

        I,

        O,

        P,

        OPEN_BRACKET,

        CLOSE_BRACKET,

        ENTER,

        NUMPAD_SEVEN,

        NUMPAD_EIGHT,

        NUMPAD_NINE,

        NUMPAD_PLUS,

        CAPS_LOCK,

        A,

        S,

        D,

        F,

        G,

        H,

        J,

        K,

        L,

        SEMICOLON,

        APOSTROPHE,

        HASHTAG,

        NUMPAD_FOUR,

        NUMPAD_FIVE,

        NUMPAD_SIX,

        LEFT_SHIFT,

        BACKSLASH_UK,

        Z,

        X,

        C,

        V,

        B,

        N,

        M,

        COMMA,

        PERIOD,

        FORWARD_SLASH,

        RIGHT_SHIFT,

        UP_ARROW,

        NUMPAD_ONE,

        NUMPAD_TWO,

        NUMPAD_THREE,

        NUMPAD_ENTER,

        LEFT_CONTROL,

        FN_Key,

        LEFT_WINDOWS,

        LEFT_ALT,

        SPACE,

        RIGHT_ALT,

        MENU,

        RIGHT_CONTROL,

        ARROW_LEFT,

        DOWN_ARROW,

        RIGHT_ARROW,

        NUMPAD_0,

        NUMPAD_PERIOD,
        PRINT_SCREEN,
        BACKSLASH
    }

    public enum Layout
    {
        ISO,
        ANSI
    }

    public static class Layouts
    {
        public static readonly Dictionary<Key, byte> ISO = new Dictionary<Key, byte>
        {
            { Key.LEFT_CONTROL , 105},
            { Key.FN_Key , 107},
            { Key.LEFT_WINDOWS , 108},
            { Key.LEFT_ALT , 109},
            { Key.SPACE , 112},
            { Key.RIGHT_ALT , 115},
            { Key.MENU , 116},
            { Key.RIGHT_CONTROL , 117},
            { Key.ARROW_LEFT , 118},
            { Key.DOWN_ARROW , 119},
            { Key.RIGHT_ARROW , 120},
            { Key.NUMPAD_0 , 121},
            { Key.NUMPAD_PERIOD , 122},
            { Key.LEFT_SHIFT , 84},
            { Key.BACKSLASH_UK , 86},
            { Key.Z , 87},
            { Key.X , 88},
            { Key.C , 89},
            { Key.V , 90},
            { Key.B , 91},
            { Key.N , 92},
            { Key.M , 93},
            { Key.COMMA , 94},
            { Key.PERIOD , 95},
            { Key.FORWARD_SLASH , 96},
            { Key.RIGHT_SHIFT , 97},
            { Key.UP_ARROW , 98},
            { Key.NUMPAD_ONE , 99},
            { Key.NUMPAD_TWO , 100},
            { Key.NUMPAD_THREE , 101},
            { Key.NUMPAD_ENTER , 102},
            { Key.CAPS_LOCK , 63},
            { Key.A , 65},
            { Key.S , 66},
            { Key.D , 67},
            { Key.F , 68},
            { Key.G , 69},
            { Key.H , 70},
            { Key.J , 71},
            { Key.K , 72},
            { Key.L , 73},
            { Key.SEMICOLON , 74},
            { Key.APOSTROPHE , 75},
            { Key.HASHTAG , 76},
            { Key.NUMPAD_FOUR , 78},
            { Key.NUMPAD_FIVE , 79},
            { Key.NUMPAD_SIX , 80},
            { Key.TAB , 42},
            { Key.Q , 44},
            { Key.W , 45},
            { Key.E , 46},
            { Key.R , 47},
            { Key.T , 48},
            { Key.Y , 49},
            { Key.U , 50},
            { Key.I , 51},
            { Key.O , 52},
            { Key.P , 53},
            { Key.OPEN_BRACKET , 54},
            { Key.CLOSE_BRACKET , 55},
            { Key.ENTER , 56},
            { Key.NUMPAD_SEVEN , 57},
            { Key.NUMPAD_EIGHT , 58},
            { Key.NUMPAD_NINE , 59},
            { Key.NUMPAD_PLUS , 60},
            { Key.TILDE , 21},
            { Key.ONE , 22},
            { Key.TWO , 23},
            { Key.THREE , 24},
            { Key.FOUR , 25},
            { Key.FIVE , 26},
            { Key.SIX , 27},
            { Key.SEVEN , 28},
            { Key.EIGHT , 29},
            { Key.NINE , 30},
            { Key.ZERO , 31},
            { Key.MINUS , 32},
            { Key.EQUALS , 33},
            { Key.BACKSPACE , 35},
            { Key.NUMLOCK , 36},
            { Key.NUMPAD_DIVIDE , 37},
            { Key.NUMPAD_MULTIPLY , 38},
            { Key.NUMPAD_MINUS , 39},
            { Key.ESCAPE , 0},
            { Key.F1 , 1},
            { Key.F2 , 2},
            { Key.F3 , 3},
            { Key.F4 , 4},
            { Key.F5 , 5},
            { Key.F6 , 6},
            { Key.F7 , 7},
            { Key.F8 , 8},
            { Key.F9 , 9},
            { Key.F10 , 10},
            { Key.F11 , 11},
            { Key.F12 , 12},
            { Key.INSERT , 13},
            { Key.DELETE , 14},
            { Key.HOME , 15},
            { Key.END , 16},
            { Key.PAGE_UP , 17},
            { Key.PAGE_DOWN , 18 }
        };

        public static readonly Dictionary<Key, byte> ANSI = new Dictionary<Key, byte>
        {
            { Key.LEFT_CONTROL , 105},
            { Key.FN_Key , 107},
            { Key.LEFT_WINDOWS , 108},
            { Key.LEFT_ALT , 109},
            { Key.SPACE , 112},
            { Key.RIGHT_ALT , 115},
            { Key.MENU , 116},
            { Key.RIGHT_CONTROL , 117},
            { Key.ARROW_LEFT , 118},
            { Key.DOWN_ARROW , 119},
            { Key.RIGHT_ARROW , 120},
            { Key.LEFT_SHIFT , 85},
            { Key.Z , 87},
            { Key.X , 88},
            { Key.C , 89},
            { Key.V , 90},
            { Key.B , 91},
            { Key.N , 92},
            { Key.M , 93},
            { Key.COMMA , 94},
            { Key.PERIOD , 95},
            { Key.FORWARD_SLASH , 96},
            { Key.RIGHT_SHIFT , 97},
            { Key.UP_ARROW , 98},
            { Key.END , 99},
            { Key.CAPS_LOCK , 63},
            { Key.A , 65},
            { Key.S , 66},
            { Key.D , 67},
            { Key.F , 68},
            { Key.G , 69},
            { Key.H , 70},
            { Key.J , 71},
            { Key.K , 72},
            { Key.L , 73},
            { Key.SEMICOLON , 74},
            { Key.APOSTROPHE , 75},
            { Key.ENTER , 77},
            { Key.PAGE_DOWN , 78},
            { Key.TAB , 42},
            { Key.Q , 44},
            { Key.W , 45},
            { Key.E , 46},
            { Key.R , 47},
            { Key.T , 48},
            { Key.Y , 49},
            { Key.U , 50},
            { Key.I , 51},
            { Key.O , 52},
            { Key.P , 53},
            { Key.OPEN_BRACKET , 54},
            { Key.CLOSE_BRACKET , 55},
            { Key.BACKSLASH , 56},
            { Key.PAGE_UP , 57},
            { Key.TILDE , 21},
            { Key.ONE , 22},
            { Key.TWO , 23},
            { Key.THREE , 24},
            { Key.FOUR , 25},
            { Key.FIVE , 26},
            { Key.SIX , 27},
            { Key.SEVEN , 28},
            { Key.EIGHT , 29},
            { Key.NINE , 30},
            { Key.ZERO , 31},
            { Key.MINUS , 32},
            { Key.EQUALS , 33},
            { Key.BACKSPACE , 35},
            { Key.HOME , 36},
            { Key.ESCAPE , 0},
            { Key.F1 , 1},
            { Key.F2 , 2},
            { Key.F3 , 3},
            { Key.F4 , 4},
            { Key.F5 , 5},
            { Key.F6 , 6},
            { Key.F7 , 7},
            { Key.F8 , 8},
            { Key.F9 , 9},
            { Key.F10 , 10},
            { Key.F11 , 11},
            { Key.F12 , 12},
            { Key.INSERT , 13},
            { Key.PRINT_SCREEN , 14},
            { Key.DELETE , 15 }
        };
    }
}
