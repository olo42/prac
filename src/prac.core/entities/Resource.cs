using System;
using System.Collections;
using System.Collections.Generic;

namespace com.github.olo42.prac.core.entities
{
  public class Resource
  {
    public Resource(string name)
    {
      this.Name = name;
    }
    public string Name { get; set; }
  }
}