using PersonService.Core.Commands;
using PersonService.Core.Domains;

namespace PersonService.Core.Handlers.CommandHandlers
{
    public class SignUpCommandHandler
    {
        public async Task Handle(SignUpCommand request, CancellationToken cancellationToken)
        {
            var person = new Person
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName
            };

            var authentication = new Authentication
            {
                Password = request.Password,
                Salt = Guid.NewGuid().ToString(),
                Person = person
            };
        }
    }
}
