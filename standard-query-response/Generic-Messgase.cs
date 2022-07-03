namespace Drysdale.Standard.Query.Response
{
    /// <summary>
    /// Class.Generic.Operational.Message
    /// </summary>
    public class Message
    {
        #region AddSuccess...
        /// <summary>
        /// AddSuccess
        /// </summary>
        /// <param name="modelName"></param>
        /// <returns></returns>
        public static string AddSuccess(string modelName) => $"{modelName}, Added Successfully";
        #endregion

        #region QuerySuccess...
        /// <summary>
        /// QuerySuccess
        /// </summary>
        /// <param name="modelName"></param>
        /// <returns></returns>
        public static string QuerySuccess(string modelName) => $"Query On {modelName},  Successful";
        #endregion

        #region DuplcateError...
        /// <summary>
        /// DuplcateError
        /// </summary>
        /// <param name="modelName"></param>
        /// <returns></returns>
        public static string DuplcateError(string modelName) => $"Duplicate {modelName}, Detected!";
        #endregion

        #region NotFoundError(404)...
        /// <summary>
        /// NotFoundError(404)
        /// </summary>
        /// <param name="modelName"></param>
        /// <returns></returns>
        public static string NotFoundError(string modelName) => $"{modelName}, Not Found!";
        #endregion

        #region TechError...
        /// <summary>
        /// TechError
        /// </summary>
        /// <param name="functionName"></param>
        /// <param name="messageDetails"></param>
        /// <returns>The Tecnical Error Message</returns>
        public static string TechError(string functionName, string messageDetails) => $"{functionName}, Detected! [{messageDetails}]";
        #endregion
    }
}
