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
    public class Table : Value
    {
        public static Table _G; // A table of all global variables

        void insert(Value value) { }
        void insert(int index, Value value) { }

        // value = table[key]
        // table[key] = value
        public object this[Value key]
        {
            get { return new Value(); }
            set { }
        }
    }
}
