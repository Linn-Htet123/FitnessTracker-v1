﻿namespace FitnessTracker.models.interfaces
{
    internal interface IUser
    {
        int UserId { get; }
        string Username { get; }
        double Weight { get; }
        double Height { get; }
        bool IsAuthenticated { get; }

        void Authenticate();

    }
}