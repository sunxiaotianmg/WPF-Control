﻿// Copyright © 2024 By HeBianGu(QQ:908293466) https://github.com/HeBianGu/WPF-Control

namespace H.Services.Message.Notice;

public interface INoticeItem
{
    string Message { get; set; }
    string Time { get; }
}
