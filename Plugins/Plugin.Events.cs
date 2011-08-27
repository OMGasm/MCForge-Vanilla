﻿/*
	Copyright 2010 MCSharp team (Modified for use with MCZall/MCLawl/MCForge)
	
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.opensource.org/licenses/ecl2.php
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCForge.Plugins
{
	public partial class Plugin
	{
        public static void CancelEvent(Events e) {
            switch (e)
            {
                case Events.BlockChange:
                    Player.cancelBlock = true;
                    break;
                case Events.Chat:
                    Player.cancelchat = true;
                    break;
                case Events.Command:
                    Player.cancelcommand = true;
                    break;
                case Events.LevelLoad:
                    Level.cancelsave = true;
                    break;
                case Events.LevelSave:
                    Level.cancelload = true;
                    break;
            }
        }
	}
}