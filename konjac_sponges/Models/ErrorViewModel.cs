using System;

namespace konjac_sponges.Models
{
    public class ErrorViewModel
    {
        // get and set parameters.
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
