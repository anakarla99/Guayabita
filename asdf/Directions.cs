using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject
{ /// <summary>
/// el objetivo de este enum es guardar la direccion de la serpiente antes de actualizarse
/// </summary>
    public enum Directions
    {
        Nothing = -1,
        Down,
        Right,
        Up,
        Left
    }
}
