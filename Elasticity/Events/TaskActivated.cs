﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elasticity.Events
{
    public class TaskActivated : Event
    {
        public TaskActivated()
        {            
        }

        public TaskActivated(Guid taskId)
        {
            this.TaskId = taskId;
        }

        public Guid TaskId { get; set; }
    }
}
