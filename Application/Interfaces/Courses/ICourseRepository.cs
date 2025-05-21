﻿using Domain.Entities;

namespace Application.Interfaces.Courses
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetAllCoursesAsync();
        Task<Course?> GetCourseByIdAsync(int courseId);
        Task<bool> IsTitleDuplicateAsync(string title);
        Task AddCourseAsync(Course course);
        Task UpdateCourseAsync(Course course);
        Task DeleteCourseAsync(Course course);
        Task UpdateDescriptionAsync(int courseId, string description);
    }

}
