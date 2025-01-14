﻿namespace AvroConvert.Write.Resolvers
{
    using Exceptions;
    using Models;
    using Schema;

    public class Enum
    {
        public Encoder.WriteItem Resolve(EnumSchema es)
        {
            return (value, e) =>
            {
                if (!(value is Models.Enum) || !((Models.Enum)value).Schema.Equals(es))
                {
                    throw new AvroTypeMismatchException(
                        "[GenericEnum] required to write against [Enum] schema but found " + value.GetType());
                }

                e.WriteEnum(es.Ordinal(((Models.Enum)value).Value));
            };
        }
    }
}
