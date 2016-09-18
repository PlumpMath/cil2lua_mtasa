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

namespace Lua
{
    public class Value
    {
        // Matches "type" function in lua
        public enum Type
        {
            NIL,
            BOOLEAN,
            NUMBER,
            STRING,
            FUNCTION,
            USERDATA,
            THREAD,
            TABLE
        }

        public Type type;
        public bool isNil()         { return false; }   // type(value) == "nil"
        public bool isBoolean()     { return false; }   // type(value) == "boolean"
        public bool isNumber()      { return false; }   // type(value) == "number"
        public bool isString()      { return false; }   // type(value) == "string"
        public bool isFunction()    { return false; }   // type(value) == "function"
        public bool isUserdata()    { return false; }   // type(value) == "userdata"
        public bool isThread()      { return false; }   // type(value) == "thread"
        public bool isTable()       { return false; }   // type(value) == "table"
    }
}
