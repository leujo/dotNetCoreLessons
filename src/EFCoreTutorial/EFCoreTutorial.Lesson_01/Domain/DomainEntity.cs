﻿using System;

namespace EFCoreTutorial.Lesson_01.Domain
{
	public abstract class DomainEntity
	{
		public Guid Id { get; protected set; }

		protected DomainEntity()
		{
			Id = Guid.NewGuid();
		}
	}
}