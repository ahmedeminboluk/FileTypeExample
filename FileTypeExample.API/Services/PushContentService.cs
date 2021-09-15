using AutoMapper;
using FileTypeExample.API.Models;
using FileTypeExample.API.Repository;
using FileTypeExample.API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileTypeExample.API.Services
{
    public class PushContentService : IPushContentService
    {
        private readonly IRepository<PushContent> _repository;
        private readonly IMapper _mapper;

        public PushContentService(IRepository<PushContent> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task AddAsync(PushContentViewModel pushContentVM)
        {
            var document = _mapper.Map<PushContent>(pushContentVM);
            await _repository.AddAsync(document);
        }

        public async Task<IEnumerable<PushContentViewModel>> GetAllAsync()
        {
            var documents = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<PushContentViewModel>>(documents);
        }

        public async Task<PushContentViewModel> GetByIdAsync(string id)
        {
            var document = await _repository.GetByIdAsync(id);
            return _mapper.Map<PushContentViewModel>(document);
        }
    }
}
