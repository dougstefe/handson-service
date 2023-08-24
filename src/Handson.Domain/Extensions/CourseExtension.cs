using Handson.Domain.Entities;
using Handson.Shared.Exceptions;

namespace Handson.Domain.Extensions
{
    public static class CourseExtension
    {
        public static void ThrowIfInvalid(this Course course)
        {
            var message = $"The {nameof(Course)}.{{prop}} is null or empty.";
            if (string.IsNullOrEmpty(course.Name))
            {
                throw new DomainValidationException(string.Format(message, nameof(Course.Name)));
            }
            if (string.IsNullOrEmpty(course.Title))
            {
                throw new DomainValidationException(string.Format(message, nameof(Course.Title)));
            }
            if (string.IsNullOrEmpty(course.Description))
            {
                throw new DomainValidationException(string.Format(message, nameof(Course.Description)));
            }
        }
    }
}
