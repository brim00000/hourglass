// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TimerOptionsTest.cs" company="Chris Dziemborowicz">
//   Copyright (c) Chris Dziemborowicz. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Hourglass.Test;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Timing;

/// <summary>
/// Contains tests for the <see cref="TimerOptions"/> class.
/// </summary>
[TestClass]
public sealed class TimerOptionsTest
{
    /// <summary>
    /// Tests that <see cref="TimerOptions"/> copy construction keeps the close-on-click-when-expired option.
    /// </summary>
    [TestMethod]
    public void CopyConstructorKeepsCloseWhenExpiredAfterClick()
    {
        // Arrange
        TimerOptions options = new()
        {
            CloseWhenExpiredAfterClick = true
        };

        // Act
        TimerOptions copy = new(options);

        // Assert
        Assert.IsTrue(copy.CloseWhenExpiredAfterClick);
    }

    /// <summary>
    /// Tests that <see cref="TimerOptions.ToTimerOptionsInfo"/> keeps the close-on-click-when-expired option.
    /// </summary>
    [TestMethod]
    public void ToTimerOptionsInfoKeepsCloseWhenExpiredAfterClick()
    {
        // Arrange
        TimerOptions options = new()
        {
            CloseWhenExpiredAfterClick = true
        };

        // Act
        TimerOptions restored = new(options.ToTimerOptionsInfo());

        // Assert
        Assert.IsTrue(restored.CloseWhenExpiredAfterClick);
    }
}
