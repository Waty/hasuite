/*  HaRepacker - WZ extractor and repacker
 * Copyright (C) 2009, 2010 haha01haha01
   
 * This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

 * This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

 * You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HaRepackerLib;

namespace HaRepackerLib
{
    public class UndoRedoManager
    {
        public List<UndoRedoBatch> UndoList = new List<UndoRedoBatch>();
        public List<UndoRedoBatch> RedoList = new List<UndoRedoBatch>();
        private HaRepackerMainPanel parentPanel;

        public UndoRedoManager(HaRepackerMainPanel parentPanel)
        {
            this.parentPanel = parentPanel;
        }

        public void AddUndoBatch(List<UndoRedoAction> actions)
        {
            UndoRedoBatch batch = new UndoRedoBatch() { Actions = actions };
            UndoList.Add(batch);
            RedoList.Clear();
        }

        #region Undo Actions Creation
        public static UndoRedoAction ObjectAdded(WzNode parent, WzNode item)
        {
            return new UndoRedoAction(item, parent, UndoRedoType.ObjectAdded);
        }

        public static UndoRedoAction ObjectRemoved(WzNode parent, WzNode item)
        {
            return new UndoRedoAction(item, parent, UndoRedoType.ObjectRemoved);
        }
        #endregion

        public void Undo()
        {
            UndoRedoBatch action = UndoList[UndoList.Count - 1];
            action.UndoRedo();
            action.SwitchActions();
            UndoList.RemoveAt(UndoList.Count - 1);
            RedoList.Add(action);
        }

        public void Redo()
        {
            UndoRedoBatch action = RedoList[RedoList.Count - 1];
            action.UndoRedo();
            action.SwitchActions();
            RedoList.RemoveAt(RedoList.Count - 1);
            UndoList.Add(action);
        }
    }

    public class UndoRedoBatch
    {
        public List<UndoRedoAction> Actions = new List<UndoRedoAction>();

        public void UndoRedo()
        {
            foreach (UndoRedoAction action in Actions) action.UndoRedo();
        }

        public void SwitchActions()
        {
            foreach (UndoRedoAction action in Actions) action.SwitchAction();
        }
    }

    public class UndoRedoAction
    {
        private WzNode item;
        private WzNode parent;
        private UndoRedoType type;

        public UndoRedoAction(WzNode item, WzNode parent, UndoRedoType type)
        {
            this.item = item;
            this.parent = parent;
            this.type = type;
        }

        public void UndoRedo()
        {
            switch (type)
            {
                case UndoRedoType.ObjectAdded:
                    item.Delete();
                    break;
                case UndoRedoType.ObjectRemoved:
                    parent.AddNode(item);
                    break;
            }
        }


        public unsafe void SwitchAction()
        {
            switch (type)
            {
                case UndoRedoType.ObjectAdded:
                    type = UndoRedoType.ObjectRemoved;
                    break;
                case UndoRedoType.ObjectRemoved:
                    type = UndoRedoType.ObjectAdded;
                    break;

            }
        }
    }

    public enum UndoRedoType
    {
        ObjectAdded,
        ObjectRemoved,
        ObjectChanged
    }
}
