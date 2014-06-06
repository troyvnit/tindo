using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace TinDo.Data.Infrastructure
{
    public class StateHelper
    {
        public static EntityState ConvertState(ObjectState state)
        {
            switch (state)
            {
                case ObjectState.Added:
                    return EntityState.Added;

                case ObjectState.Modified:
                    return EntityState.Modified;

                case ObjectState.Deleted:
                    return EntityState.Deleted;

                default:
                    return EntityState.Unchanged;
            }
        }

        public static ObjectState ConvertState(EntityState state)
        {
            switch (state)
            {
                case EntityState.Detached:
                    return ObjectState.Unchanged;

                case EntityState.Unchanged:
                    return ObjectState.Unchanged;

                case EntityState.Added:
                    return ObjectState.Added;

                case EntityState.Deleted:
                    return ObjectState.Deleted;

                case EntityState.Modified:
                    return ObjectState.Modified;

                default:
                    throw new ArgumentOutOfRangeException("state");
            }
        }
    }

    public enum ObjectState
    {
        Unchanged,
        Added,
        Modified,
        Deleted
    }

    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }
    }

    public abstract class Entity : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}