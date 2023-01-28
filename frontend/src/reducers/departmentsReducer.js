import { createSlice, createAsyncThunk } from "@reduxjs/toolkit";
import { fetchDepartments } from "../api";

export const getDepartments = createAsyncThunk(
  "department",
  async (id, thunkAPI) => {
    try {
      const response = await fetchDepartments(id);
      return response.data;
    } catch (error) {
      return error.response.status === 404
        ? thunkAPI.rejectWithValue("Invalid API Request")
        : thunkAPI.rejectWithValue(error);
    }
  }
);

const initialState = {
  loading: false,
  errorMessage: "",
  data: [],
};

export const departmentSlice = createSlice({
  name: "departments",
  initialState,

  extraReducers(builder) {
    builder
      .addCase(getDepartments.pending, (state, action) => {
        state.errorMessage = "";
        state.loading = true;
      })
      .addCase(getDepartments.rejected, (state, action) => {
        state.loading = false;
        state.errorMessage = action.payload;
      })
      .addCase(getDepartments.fulfilled, (state, { payload }, action) => {
        state.loading = false;
        state.data = payload;
      });
  },
});

export default departmentSlice.reducer;
