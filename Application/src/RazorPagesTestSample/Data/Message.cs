using System.ComponentModel.DataAnnotations;

namespace RazorPagesTestSample.Data
{
    #region snippet1
    public class Message
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(256, ErrorMessage = "There's a 256 character limit on messages. Please shorten your message.")]
        public string Text { get; set; }
    }
    #endregion
}
