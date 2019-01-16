namespace Sample_Istio_Review.Dtos
{
    /// <summary>
    /// Review Dto.
    /// </summary>
    public class ReviewDto
    {
        /// <summary>
        /// Review Content.
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Review Base64 image avatar.
        /// </summary>
        public string Base64SvgAvatar { get; set; }
        /// <summary>
        /// Star.
        /// </summary>
        public int Star { get; set; }
    }
}