// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace CCPPApplicationML.Model
{
    public class ModelInput
    {
        [ColumnName("taxi_id"), LoadColumn(0)]
        public float Taxi_id { get; set; }


        [ColumnName("trip_seconds"), LoadColumn(1)]
        public float Trip_seconds { get; set; }


        [ColumnName("trip_miles"), LoadColumn(2)]
        public float Trip_miles { get; set; }


        [ColumnName("fare"), LoadColumn(3)]
        public float Fare { get; set; }


        [ColumnName("tips"), LoadColumn(4)]
        public float Tips { get; set; }


        [ColumnName("trip_total"), LoadColumn(5)]
        public float Trip_total { get; set; }


        [ColumnName("payment_type"), LoadColumn(6)]
        public float Payment_type { get; set; }

    }
}