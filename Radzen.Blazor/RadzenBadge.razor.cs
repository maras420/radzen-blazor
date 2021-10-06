﻿using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Radzen.Blazor
{
    public partial class RadzenBadge : RadzenComponent
    {
        protected override string GetComponentCssClass()
        {
            var classList = new List<string>();

            classList.Add("rz-badge");
            classList.Add($"rz-badge-{BadgeStyle.ToString().ToLower()}");

            if (IsPill)
            {
                classList.Add("rz-badge-pill");
            }

            return string.Join(" ", classList);
        }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public BadgeStyle BadgeStyle { get; set; }

        [Parameter]
        public bool IsPill { get; set; }
    }
}
