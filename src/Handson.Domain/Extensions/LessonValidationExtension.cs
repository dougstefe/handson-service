using Handson.Domain.Entities;
using Handson.Shared.Exceptions;

namespace Handson.Domain.Extensions
{
    public static class LessonExtension
    {
        public static void ThrowIfInvalid(this Lesson course)
        {
            var message = $"The {nameof(Lesson)}.{{prop}} is null or empty.";
            var messageIsZero = $"The {nameof(Lesson)}.{{prop}} is zero.";
            if (string.IsNullOrEmpty(course.Name))
            {
                throw new DomainValidationException(string.Format(message, nameof(Lesson.Name)));
            }
            if (string.IsNullOrEmpty(course.Description))
            {
                throw new DomainValidationException(string.Format(message, nameof(Lesson.Description)));
            }
            if (course.DurationInSeconds <= 0)
            {
                throw new DomainValidationException(string.Format(messageIsZero, nameof(Lesson.DurationInSeconds)));
            }
            if (course.Order <= 0)
            {
                throw new DomainValidationException(string.Format(messageIsZero, nameof(Lesson.Order)));
            }
        }
    }
}
