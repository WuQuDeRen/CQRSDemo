﻿namespace CQRSFramework.Events
{
    public interface IHandle<in TEvent> where TEvent : IEvent
    {
        void Handle(TEvent e);
    }
}