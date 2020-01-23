double[] fareEstimator(int ride_time, int ride_distance, double[] cost_per_minute, double[] cost_per_mile) {
    
    var fare = new double[cost_per_minute.Length];
    
    for(var fareCount = 0; fareCount < cost_per_minute.Length; fareCount++)
    {
        fare[fareCount] = (cost_per_minute[fareCount] * ride_time + cost_per_mile[fareCount] * ride_distance);
    }
    
    return fare;
}