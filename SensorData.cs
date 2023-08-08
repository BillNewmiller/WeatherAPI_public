using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class SensorData504
    {
        public int battery_voltage { get; set; }
        public int wifi_rssi { get; set; }
        public object network_error { get; set; }
        public string ip_v4_gateway { get; set; }
        public object bluetooth_version { get; set; }
        public object bgn { get; set; }
        public int firmware_version { get; set; }
        public int local_api_queries { get; set; }
        public int rx_bytes { get; set; }
        public int health_version { get; set; }
        public int radio_version { get; set; }
        public int ip_address_type { get; set; }
        public int link_uptime { get; set; }
        public int input_voltage { get; set; }
        public int tx_bytes { get; set; }
        public string ip_v4_netmask { get; set; }
        public int rapid_records_sent { get; set; }
        public int uptime { get; set; }
        public int touchpad_wakeups { get; set; }
        public string ip_v4_address { get; set; }
        public int bootloader_version { get; set; }
        public int espressif_version { get; set; }
        public object dns_type_used { get; set; }
        public int network_type { get; set; }
        public int ts { get; set; }
    }

    public class SensorData43
    {
        public int rx_state { get; set; }
        public double wind_speed_hi_last_2_min { get; set; }
        public double hum { get; set; }
        public int wind_dir_at_hi_speed_last_10_min { get; set; }
        public double wind_chill { get; set; }
        public int rain_rate_hi_last_15_min_clicks { get; set; }
        public double thw_index { get; set; }
        public int wind_dir_scalar_avg_last_10_min { get; set; }
        public int rain_size { get; set; }
        public object uv_index { get; set; }
        public double wind_speed_last { get; set; }
        public int rainfall_last_60_min_clicks { get; set; }
        public double wet_bulb { get; set; }
        public int rainfall_monthly_clicks { get; set; }
        public double wind_speed_avg_last_10_min { get; set; }
        public int wind_dir_at_hi_speed_last_2_min { get; set; }
        public double rainfall_daily_in { get; set; }
        public int wind_dir_last { get; set; }
        public double rainfall_daily_mm { get; set; }
        public int rain_storm_last_clicks { get; set; }
        public int tx_id { get; set; }
        public int rain_storm_last_start_at { get; set; }
        public int rain_rate_hi_clicks { get; set; }
        public double rainfall_last_15_min_in { get; set; }
        public double rainfall_daily_clicks { get; set; }
        public double dew_point { get; set; }
        public double rainfall_last_15_min_mm { get; set; }
        public double rain_rate_hi_in { get; set; }
        public int rain_storm_clicks { get; set; }
        public double rain_rate_hi_mm { get; set; }
        public int rainfall_year_clicks { get; set; }
        public double rain_storm_in { get; set; }
        public int rain_storm_last_end_at { get; set; }
        public double rain_storm_mm { get; set; }
        public int wind_dir_scalar_avg_last_2_min { get; set; }
        public double heat_index { get; set; }
        public double rainfall_last_24_hr_in { get; set; }
        public double rainfall_last_60_min_mm { get; set; }
        public int trans_battery_flag { get; set; }
        public double rainfall_last_60_min_in { get; set; }
        public object rain_storm_start_time { get; set; }
        public double rainfall_last_24_hr_mm { get; set; }
        public double rainfall_year_in { get; set; }
        public double wind_speed_hi_last_10_min { get; set; }
        public int rainfall_last_15_min_clicks { get; set; }
        public double rainfall_year_mm { get; set; }
        public int wind_dir_scalar_avg_last_1_min { get; set; }
        public double temp { get; set; }
        public double wind_speed_avg_last_2_min { get; set; }
        public object solar_rad { get; set; }
        public double rainfall_monthly_mm { get; set; }
        public double rain_storm_last_mm { get; set; }
        public double wind_speed_avg_last_1_min { get; set; }
        public object thsw_index { get; set; }
        public double rainfall_monthly_in { get; set; }
        public double rain_rate_last_mm { get; set; }
        public int rain_rate_last_clicks { get; set; }
        public int rainfall_last_24_hr_clicks { get; set; }
        public double rain_storm_last_in { get; set; }
        public double rain_rate_last_in { get; set; }
        public double rain_rate_hi_last_15_min_mm { get; set; }
        public double rain_rate_hi_last_15_min_in { get; set; }
        public int ts { get; set; }
    }

    public class SensorData243
    {
        public double temp_in { get; set; }
        public double heat_index_in { get; set; }
        public double dew_point_in { get; set; }
        public int ts { get; set; }
        public double hum_in { get; set; }
    }

    public class SensorData242
    {
        public double bar_absolute { get; set; }
        public double bar_sea_level { get; set; }
        public double bar_offset { get; set; }
        public double bar_trend { get; set; }
        public int ts { get; set; }
    }

    public class Sensor
    {
        public int lsid { get; set; }
        public object data { get; set; }
        public int sensor_type { get; set; }
        public int data_structure_type { get; set; }
    }

    public class RootObject
    {
        public string station_id_uuid { get; set; }
        public List<Sensor> sensors { get; set; }
        public int generated_at { get; set; }
        public int station_id { get; set; }
    }
}