using AutoMapper;
using Contracts;
using BiddingService.Model;
using BiddingService.DTOs;

namespace BiddingService;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Bid, BidDto>();
        CreateMap<Bid, BidPlaced>();
    }
}