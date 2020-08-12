using AutoMapper;
using Santi.Api.ViewModel;
using Santi.Domain.Dto;
using Santi.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Santi.Api.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ViewModelToDto();
            DtoToViewModel();
            DtoToModel();
            ModelToDto();
        }

        private void ViewModelToDto()
        {
            CreateMap<SantinhoViewModel, SantinhoDto>();
            CreateMap<ColinhaViewModel, ColinhaDto>();
            CreateMap<EstrategiaViewModel, EstrategiaDto>();
            CreateMap<PartidoViewModel, PartidoDto>();
            CreateMap<CandidatoViewModel, CandidatoDto>();
        }

        private void DtoToViewModel()
        {
            CreateMap<SantinhoDto, SantinhoViewModel>();
            CreateMap<ColinhaDto, ColinhaViewModel>();
            CreateMap<EstrategiaDto, EstrategiaViewModel>();
            CreateMap<PartidoDto, PartidoViewModel>();
            CreateMap<CandidatoDto, CandidatoViewModel>();
        }

        private void DtoToModel()
        {
            CreateMap<CandidatoDto, Candidato>();
            CreateMap<ColinhaDto, Colinha>();
            CreateMap<EstrategiaDto, Estrategia>();
            CreateMap<FiliacaoDto, Filiacao>();
            CreateMap<PartidoDto, Partido>();
            CreateMap<PartidoFiliacaoDto, PartidoFiliacao>();
            CreateMap<SantinhoDto, Santinho>();
        }

        private void ModelToDto()
        {
            CreateMap<Candidato, CandidatoDto>();
            CreateMap<Colinha, ColinhaDto>();
            CreateMap<Estrategia, EstrategiaDto>();
            CreateMap<Filiacao, FiliacaoDto>();
            CreateMap<Partido, PartidoDto>();
            CreateMap<PartidoFiliacao, PartidoFiliacaoDto>();
            CreateMap<Santinho, SantinhoDto>();
        }
    }
}
