using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace SandboxApp1.Commands
{
    public class AddTaskCommand : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        
        public class Handler : IRequestHandler<AddTaskCommand, Unit>
        {
            // private readonly IService _service;
            //
            // public Handler(IService service)
            // {
            //     _service = service;
            // }

            public async Task<Unit> Handle(AddTaskCommand request, CancellationToken cancellationToken)
            {
                Console.WriteLine($"really important action name:{request.Name} Description: {request.Description}");

                return await Unit.Task;
            }
        }
    }

    public interface IService
    {
    }
}