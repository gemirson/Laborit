using System;

namespace Laborit.Domain
{
    public abstract class Entity
    {
        public  Guid Id { get; protected set; }
        
        public override bool Equals(object Entity_object)
        {
            var entityCompare = Entity_object as Entity;

            if (ReferenceEquals(entityCompare, null)) return false;

            if (ReferenceEquals(this, entityCompare)) return true;

            if (GetType() != entityCompare.GetType()) return false;

            return Id == entityCompare.Id;
        }

        public static bool operator ==(Entity entity_objectA, Entity entity_objectB)
        {
            if (ReferenceEquals(entity_objectA, null) && ReferenceEquals(entity_objectB, null)) return true;

            if (ReferenceEquals(entity_objectA, null) || ReferenceEquals(entity_objectB, null)) return false;

            return entity_objectA.Equals(entity_objectB);
        }

        public static bool operator !=(Entity entity_objectA, Entity entity_objectB)
        {
            return !(entity_objectA == entity_objectB);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1307:Especificar StringComparison", Justification = "<Pendente>")]
        public override int GetHashCode()
        {
            return (GetType().ToString() + Id).GetHashCode();
        }
                    


    }
}
