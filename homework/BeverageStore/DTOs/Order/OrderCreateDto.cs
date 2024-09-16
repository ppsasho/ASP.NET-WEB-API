﻿using DTOs.OrderItem;
using System.ComponentModel.DataAnnotations;

namespace DTOs.Order
{
    public class OrderCreateDto
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public List<OrderItemDto> orderItems { get; set; }
    }
}