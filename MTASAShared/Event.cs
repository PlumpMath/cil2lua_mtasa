/*
This file is part of cil2lua_mtasa (https://github.com/DEC05EBA/cil2lua_mtasa).
cil2lua_mtasa is free software : you can redistribute it and / or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 2 of the License, or
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
    public class Event
    {
        public delegate void EventCallbackFunc(params Value[] args);
        public Event(string eventName, Element attachTo, EventCallbackFunc callbackFunc) { } // addEventHandler(eventName, attachTo, callbackFunc)
        // removeEventHandler(...) -- uses stored event name, attached to element and callback function to remove the event handler.
        // The data is stored by adding predefined code in CILTlua for defining Event as a lua class that stores the input data and then uses it in removeEventHandler.
        void remove() { }
    }
}
