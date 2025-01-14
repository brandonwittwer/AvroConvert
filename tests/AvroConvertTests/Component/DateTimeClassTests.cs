﻿namespace AvroConvertTests.Component
{
    using System;
    using AutoFixture;
    using AvroConvert;
    using Xunit;

    public class DateTimeClassTests
    {
        private readonly Fixture _fixture;

        public DateTimeClassTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void Component_ClassWithDateTime_ResultIsTheSameAsInput()
        {
            //Arrange
            ClassWithDateTime toSerialize = _fixture.Create<ClassWithDateTime>();
            //Act

            var result = AvroConvert.Serialize(toSerialize);

            var deserialized = AvroConvert.Deserialize<ClassWithDateTime>(result);

            //Assert
            Assert.NotNull(result);
            Assert.NotNull(deserialized);
            Assert.Equal(toSerialize.ArriveBy.Second, deserialized.ArriveBy.Second);
            Assert.Equal(toSerialize.ArriveBy.Minute, deserialized.ArriveBy.Minute);
            Assert.Equal(toSerialize.ArriveBy.Hour, deserialized.ArriveBy.Hour);
            Assert.Equal(toSerialize.ArriveBy.Day, deserialized.ArriveBy.Day);
            Assert.Equal(toSerialize.ArriveBy.Month, deserialized.ArriveBy.Month);
            Assert.Equal(toSerialize.ArriveBy.Year, deserialized.ArriveBy.Year);
        }

        [Fact]
        public void Component_ClassWithDefaultDateTime_ResultIsTheSameAsInput()
        {
            //Arrange
            ClassWithDateTime toSerialize = _fixture.Create<ClassWithDateTime>();
            toSerialize.ArriveBy = new DateTime();
            //Act

            var result = AvroConvert.Serialize(toSerialize);

            var deserialized = AvroConvert.Deserialize<ClassWithDateTime>(result);

            //Assert
            Assert.NotNull(result);
            Assert.NotNull(deserialized);
            Assert.Equal(toSerialize.ArriveBy.Second, deserialized.ArriveBy.Second);
            Assert.Equal(toSerialize.ArriveBy.Minute, deserialized.ArriveBy.Minute);
            Assert.Equal(toSerialize.ArriveBy.Hour, deserialized.ArriveBy.Hour);
            Assert.Equal(toSerialize.ArriveBy.Day, deserialized.ArriveBy.Day);
            Assert.Equal(toSerialize.ArriveBy.Month, deserialized.ArriveBy.Month);
            Assert.Equal(toSerialize.ArriveBy.Year, deserialized.ArriveBy.Year);
        }

        [Fact]
        public void Component_ClassWithDateTimeOffset_ResultIsTheSameAsInput()
        {
            //Arrange
            ClassWithDateTimeOffset toSerialize = _fixture.Create<ClassWithDateTimeOffset>();

            //Act
            var result = AvroConvert.Serialize(toSerialize);

            var deserialized = AvroConvert.Deserialize<ClassWithDateTimeOffset>(result);

            //Assert
            Assert.NotNull(result);
            Assert.NotNull(deserialized);
            Assert.Equal(toSerialize.yeah.Second, deserialized.yeah.Second);
            Assert.Equal(toSerialize.yeah.Minute, deserialized.yeah.Minute);
            Assert.Equal(toSerialize.yeah.Hour, deserialized.yeah.Hour);
            Assert.Equal(toSerialize.yeah.Day, deserialized.yeah.Day);
            Assert.Equal(toSerialize.yeah.Month, deserialized.yeah.Month);
            Assert.Equal(toSerialize.yeah.Year, deserialized.yeah.Year);
        }
    }
}
