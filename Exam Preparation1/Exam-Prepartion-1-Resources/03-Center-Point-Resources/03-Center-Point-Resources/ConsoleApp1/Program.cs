using System;

namespace TestApp;
public class CenterPoint
{
    // Static method that calculates and returns the closest point to the origin (0,0).
    public static string GetClosest(double x1, double y1, double x2, double y2)
    {
        // Calculate the sum of absolute values of x and y for the first point.
        double pointOne = Math.Abs(x1) + Math.Abs(y1);
        // Calculate the sum of absolute values of x and y for the second point.
        double pointTwo = Math.Abs(x2) + Math.Abs(y2);

        // Format the first point as a string for reporting.
        string firstPointReport = $"({string.Join(", ", x1, y1)})";
        // Format the second point as a string for reporting.
        string secondPointReport = $"({string.Join(", ", x2, y2)})";

        // Check if the distance of the first point is greater than the distance of the second point.
        if (pointOne > pointTwo)
        {
            // If true, the second point is closer, so return its coordinates.
            return secondPointReport;
        }
        // Check if the distance of the first point is smaller than the distance of the second point.
        else if (pointOne < pointTwo)
        {
            // If true, the first point is closer, so return its coordinates.
            return firstPointReport;
        }
        else
        {
            // If distances are equal, check if the second point has negative coordinates.
            if (x2 < 0 || y2 < 0)
            {
                // If true, the second point is considered closer, so return its coordinates.
                return secondPointReport;
            }

            // If both points have equal distances and the second point doesn't have negative coordinates,
            // consider the first point closer and return its coordinates.
            return firstPointReport;
        }
    }
}
