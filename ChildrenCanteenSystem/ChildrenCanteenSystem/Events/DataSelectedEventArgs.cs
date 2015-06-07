namespace ChildrenCanteenSystem.Events
{
    using System;
    using Enumerations;

    public class DataSelectedEventArgs : EventArgs
    {
        public DataSelectedEventArgs(SaveButtonState state)
        {
            this.SaveButtonState = state;
        }

        public SaveButtonState SaveButtonState { get; set; }
    }
}
