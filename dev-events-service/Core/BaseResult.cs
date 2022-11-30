using FluentValidation.Results;
using Newtonsoft.Json;

namespace dev_events_service.Core
{
    public class BaseResult : IResult
    {
        [JsonIgnore]
        private bool HasErrors { get; set; }

        private IList<string> _messages;

        [JsonIgnore]
        private string DefaultSuccess = "Success";

        public IList<string> Messages => HasErrors ? _messages : GetResult();

        private List<string> GetResult()
        {
            var result = new List<string> { DefaultSuccess };
            result.AddRange(_messages);
            return result;
        }

        public virtual object Data { get; set; }

        public StatusResult Status
        {
            get
            {
                if (HasErrors)
                {
                    return StatusResult.Error;
                }
                else
                {
                    return StatusResult.Ok;
                }
            }
        }

        public void AddRange(IEnumerable<string> errors)
        {
            if (errors != null)
            {
                HasErrors = true;
                ((List<string>)_messages).AddRange(errors?.ToList());
            }
        }

        public void AddRange(ValidationResult result)
        {
            if (result != null && result.Errors?.Count() > 0)
            {
                HasErrors = true;
                ((List<string>)_messages).AddRange(result.Errors.Select(x => x.ErrorMessage).ToList());
            }
        }

        public void ChangeDefaultSuccessMessage(in string newDefaultMessage)
        {
            if (!HasErrors)
            {
                DefaultSuccess = newDefaultMessage;
            }
        }

        protected BaseResult()
        {
            InitializeNotification();
        }

        public void AddSecondaryProcessInfo(in string message)
        {
            _messages.Add(message);
        }

        protected void AddError(in string error)
        {
            HasErrors = true;
            _messages.Add(error);
        }

        private void InitializeNotification()
        {
            if (_messages == null)
            {
                _messages = new List<string>();
            }
        }
    }
}
