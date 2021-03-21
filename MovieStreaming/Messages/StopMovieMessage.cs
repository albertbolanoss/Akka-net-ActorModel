﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStreaming.Messages
{
    class StopMovieMessage
    {
        public int UserId { get; private set; }

        public StopMovieMessage(int userId)
        {
            UserId = userId;
        }
    }
}
