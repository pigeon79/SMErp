﻿namespace G.Data.Definition
{
    public interface IBelongsTo : ILazyLoading
    {
        void ForeignKeyChanged();
        object ForeignKey { get; set; }
    }
}
