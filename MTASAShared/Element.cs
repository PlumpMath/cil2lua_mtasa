/*
This file is part of cil2lua_mtasa (https://github.com/DEC05EBA/cil2lua_mtasa).
cil2lua_mtasa is free software : you can redistribute it and / or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.
cil2lua_mtasa is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
GNU General Public License for more details.
You should have received a copy of the GNU General Public License
along with cil2lua_mtasa.If not, see <http://www.gnu.org/licenses/>.
*/

using Lua;

namespace MTASAShared
{
    public class Element : Userdata
    {
        public static Element client;       // "client" in event server-side event handlers
        public static Element localPlayer;  // client-side "localPlayer" element
        public static Element root;         // "root" element
        public static Element resourceRoot; // "resourceRoot" element
        public static Element guiRoot;      // "guiRoot" element

        public Vector3 position, rotation;

        public void triggerEvent(string eventName, params Value[] args) { }                             // triggerEvent(eventName, this, ...)
        public void triggerClientEvent(string eventName, params Value[] args) { }                       // triggerClientEvent(getRootElement(), eventName, this, ...)
        public void triggerClientEvent(Element sendTo, string eventName, params Value[] args) { }       // triggerClientEvent(sendTo, eventName, this, ...)
        public void triggerServerEvent(string eventName, params Value[] args) { }                       // triggerServerEvent(eventName, this, ...)
    }
}
