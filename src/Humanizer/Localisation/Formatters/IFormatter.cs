﻿namespace Humanizer.Localisation.Formatters
{
    /// <summary>
    /// Implement this interface if your language has complex rules around dealing with numbers. 
    /// For example in Romanian "5 days" is "5 zile", while "24 days" is "24 de zile" and 
    /// in Arabic 2 days is يومين not 2 يوم
    /// </summary>
    public interface IFormatter
    {
        /// <summary>
        /// Now
        /// </summary>
        /// <returns>Returns Now</returns>
        string DateHumanize_Now();

        /// <summary>
        /// Never
        /// </summary>
        /// <returns>Returns Never</returns>
        string DateHumanize_Never();

        /// <summary>
        /// Returns the string representation of the provided DateTime
        /// </summary>
        /// <param name="timeUnit"></param>
        /// <param name="timeUnitTense"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        string DateHumanize(TimeUnit timeUnit, Tense timeUnitTense, int unit, DateTimeExpressionProvider dateTimeExpressionProvider = null);

        /// <summary>
        /// 0 seconds
        /// </summary>
        /// <returns>Returns 0 seconds as the string representation of Zero TimeSpan</returns>
        string TimeSpanHumanize_Zero();

        /// <summary>
        /// Returns the string representation of the provided TimeSpan
        /// </summary>
        /// <param name="timeUnit"></param>
        /// <param name="unit"></param>
        /// <param name="toWords"></param>
        /// <returns></returns>
        string TimeSpanHumanize(TimeUnit timeUnit, int unit, bool toWords = false);
    }
}
