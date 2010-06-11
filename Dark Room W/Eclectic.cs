/*
 * Dark Room W
 *
 * NOTICE OF LICENSE
 *
 * All project source files are subject to the Open Software License (OSL 3.0)
 * that is included with this applciation in the file LICENSE.txt.
 * The license is also available online at the following URL:
 * http://opensource.org/licenses/osl-3.0.php
 * If you did not receive a copy of the license, please send
 * an email to contact@getdarkroom.com so we can send a copy to you.
 *
 * @package    dr
 * @copyright  Copyright (c) 2010 Jeffrey Fuller (http://getdarkroom.com)
 * @license    Open Software License (OSL 3.0), http://opensource.org/licenses/osl-3.0.php  
 */
 
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Xml;

namespace DarkRoom
{
    class Eclectic
    {
        // environmental constants
        public const int WM_USER = 1024;
        public const int WM_VSCROLL = 277;
        public const int WM_SETREDRAW = 0x000B;

        public const int COLOR_HIGHLIGHT = 13;
        public const int COLOR_HIGHLIGHTTEXT = 14;

        // scrollbar constants
        public enum ScrollBarActions : int
        {
            SB_LINEUP = 0,
            SB_LINEDOWN = 1,
            SB_PAGEUP = 2,
            SB_PAGEDOWN = 3,
            SB_THUMBPOSITION = 4,
            SB_THUMBTRACK = 5,
            SB_TOP = 6,
            SB_BOTTOM = 7,
            SB_ENDSCROLL = 8
        }

        // richtext constants
        public const int EM_SETTEXTMODE = (WM_USER + 89);

        public enum TextMode : int
        {
            TM_PLAINTEXT = 1,
            TM_RICHTEXT = 2,
            TM_SINGLELEVELUNDO = 4,
            TM_MULTILEVELUNDO = 8,
            TM_SINGLECODEPAGE = 16,
            TM_MULTICODEPAGE = 32
        }

        // environmental variables
        public static bool DebugMode = false;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int GetSysColor(int nIndex);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SetSysColors(int cElements, int[] lpaElements, int[] lpaRgbValues);

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern Int32 SendMessage(IntPtr hWnd, Int32 wMsg, Int32 wParam, Int32 lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern uint GetCaretBlinkTime();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SetCaretBlinkTime(uint ms);
    }
}
