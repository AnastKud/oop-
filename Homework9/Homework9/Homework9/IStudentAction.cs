﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    /// <summary>
    /// Интерфейс действия над студентами.
    /// </summary>
    public interface IStudentAction
    {
        void Execute(List<Students> students);
    }
}
