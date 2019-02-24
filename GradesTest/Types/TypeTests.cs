﻿using System;
using Xunit;
using Grades;

namespace GradesTest.Types
{
    public class TypeTests
    {
        [Fact]
        public void UppercaseString()
        {
            string name = "scott";
            name = name.ToUpper();

            Assert.Equal("SCOTT", name);
        }

        [Fact]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);

            Assert.Equal(2, date.Day);
        }

        [Fact]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);

            Assert.Equal(46, x);

        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }


        [Fact]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);

            Assert.Equal("A GradeBook", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A GradeBook";
        }


        [Fact]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Anita's grade book";

            Assert.Equal(g1.Name, g2.Name);
        }

        [Fact]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;

            Assert.NotEqual(x1, x2);
        }

        [Fact]
        public void StringComparisons()
        {
            string name1 = "Scott";
            string name2 = "scott";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.True(result);
        }


    }
}
