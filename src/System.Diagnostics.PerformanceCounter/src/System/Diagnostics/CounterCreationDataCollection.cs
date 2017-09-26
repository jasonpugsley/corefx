// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Diagnostics {
    using System;
    using System.ComponentModel;
    using System.Collections;
 
    [Serializable()]
    public class CounterCreationDataCollection : CollectionBase {
        public CounterCreationDataCollection() {
        }

        public CounterCreationDataCollection(CounterCreationDataCollection value) {
            this.AddRange(value);
        } 
        
        public CounterCreationDataCollection(CounterCreationData[] value) {
            this.AddRange(value);
        }
         
        public CounterCreationData this[int index] {
            get {
                return ((CounterCreationData)(List[index]));
            }
            set {
                List[index] = value;
            }
        }
        
        public int Add(CounterCreationData value) {
            return List.Add(value);
        }

        public void AddRange(CounterCreationData[] value) {
            if (value == null) {
                throw new ArgumentNullException("value");
            }
            for (int i = 0; ((i) < (value.Length)); i = ((i) + (1))) {
                this.Add(value[i]);
            }
        }

        public void AddRange(CounterCreationDataCollection value) {
            if (value == null) {
                throw new ArgumentNullException("value");
            }
            int currentCount = value.Count;
            for (int i = 0; i < currentCount; i = ((i) + (1))) {
                this.Add(value[i]);
            }
        }
                
        public bool Contains(CounterCreationData value) {
            return List.Contains(value);
        }
        
        public void CopyTo(CounterCreationData[] array, int index) {
            List.CopyTo(array, index);
        }
        
        public int IndexOf(CounterCreationData value) {
            return List.IndexOf(value);
        }
        
        public void Insert(int index, CounterCreationData value) {
            List.Insert(index, value);
        }
        
        public virtual void Remove(CounterCreationData value) {
            List.Remove(value);
        }       

        protected override void OnValidate(object value) {
            if (value == null)
                throw new ArgumentNullException("value");
            
            CounterCreationData dataToAdd = value as CounterCreationData;
            if (dataToAdd == null) 
                throw new ArgumentException(SR.Format(SR.MustAddCounterCreationData));
        }
        
    }    
}
  
