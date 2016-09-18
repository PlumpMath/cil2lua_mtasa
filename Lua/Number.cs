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
    // Represents "Number" in lua (which is defined as a double)
    public class Number : Value
    {
        public Number() { }
        public Number(int value) { }

        public static implicit operator Number(int rhs) { return new Number(); }
        public static implicit operator Number(float rhs) { return new Number(); }
        public static implicit operator Number(double rhs) { return new Number(); }

        public static implicit operator int(Number rhs) { return 0; }
        public static implicit operator float(Number rhs) { return 0; }
        public static implicit operator double(Number rhs) { return 0; }

        public static Number operator +(Number lhs, Number rhs) { return new Number(); }
        public static Number operator -(Number lhs, Number rhs) { return new Number(); }
        public static Number operator *(Number lhs, Number rhs) { return new Number(); }
        public static Number operator /(Number lhs, Number rhs) { return new Number(); }

        public static Number operator ==(Number lhs, Number rhs) { return new Number(); }
        public static Number operator !=(Number lhs, Number rhs) { return new Number(); }
        public static Number operator <(Number lhs, Number rhs) { return new Number(); }
        public static Number operator <=(Number lhs, Number rhs) { return new Number(); }
        public static Number operator >(Number lhs, Number rhs) { return new Number(); }
        public static Number operator >=(Number lhs, Number rhs) { return new Number(); }

        public override string ToString() { return ""; }
    }
}
