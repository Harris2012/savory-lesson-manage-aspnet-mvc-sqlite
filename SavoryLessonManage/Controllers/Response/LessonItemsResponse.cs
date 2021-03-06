﻿using SavoryLessonManage.Vo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavoryLessonManage.Controllers.Response
{
    public class LessonItemsResponse : BaseResponse
    {
        [JsonProperty("items")]
        public List<LessonVo> Items { get; set; }
    }
}
