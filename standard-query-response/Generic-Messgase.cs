namespace Drysdale.Standard.Query.Response
{
    /// <summary>
    /// Class.Message
    /// </summary>
    public class Message
    {
        /// <summary>
        /// AddSuccess
        /// </summary>
        /// <param name="modelName"></param>
        /// <returns></returns>
        public static string AddSuccess(string modelName) => $"{modelName}, Added Successfully";

        /// <summary>
        /// QuerySuccess
        /// </summary>
        /// <param name="modelName"></param>
        /// <returns></returns>
        public static string QuerySuccess(string modelName) => $"Query On {modelName},  Successful";
    }
}
