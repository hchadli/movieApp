﻿using Application.Common.TvShows.Commands;
using Application.Common.TvShows.Dtos;
using Application.Common.TvShows.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvShowsController : ControllerBase
    {
        public readonly IMediator _mediator;

        public TvShowsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IEnumerable<TvShowDto.TvShowIndex>> GetActors()
        {
            return await _mediator.Send(new GetTvShowsQuery());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<TvShowDto.TvShowDetail>> Get([FromRoute] int id)
        {
            var tvShows = _mediator.Send(new GetTvShowByIdQuery(id));
            return Ok(tvShows);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateTvShowCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}
